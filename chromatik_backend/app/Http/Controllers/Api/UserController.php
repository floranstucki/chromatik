<?php

namespace App\Http\Controllers\Api;
use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use App\Http\Resources\UserResource;
use App\Http\Services\UserService;
class UserController extends Controller{
    public function __construct(private UserService $_userService){}

    public function index(){
        try {
            $users= $this->_userService->getUsers();
            if($users->isEmpty()){
                return response()->json(['message' => 'No users found', 'code' => 404 ]);
            }
            return UserResource::collection($users);
        } catch (\Exception $e) {
            throw $e;
        }
    }
    public function show(int $id){
        try {
            $user= $this->_userService->getUserById($id);
            return UserResource::collection($user);
        } catch (\Exception $e) {
            throw $e;
        }
    }
    public function update(Request $request, int $id){
        try {
            $this->_userService->updateUser($request, $id);
            $user = $this->_userService->getUserById($id);
            return ['message' => 'User updated successfully', 'user' => new UserResource($user), 'code' => 200];
        } catch (\Exception $e) {
            throw $e;
        }
    }
    public function destroy(int $id){
        try {
            $this->_userService->deleteUser($id);
            return ['message' => 'User deleted successfully', 'code' => 200];
        } catch (\Exception $e) {
            throw $e;
        }
    }
    public function showFav(int $id)
    {
        try {
            $userFavorites = $this->_userService->getFavoritesByUserId($id);
            if($userFavorites->isEmpty()){
                //return response()->json(['message' => 'No favorites found'], 404);
            }
            return response()->json(["favorites" => $userFavorites],200);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function storeFav(int $user_id, Request $request)
    {
        try {
            $userFavorites = $this->_userService->storeFavorites($user_id, $request);
            return ['message' => 'Favorite created successfully', 'userFavorite'=> new UserResource($userFavorites), 'code' => 200];
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function destroyFav(int $user_id, Request $request)
    {
       
        try {
            $stock_id = $request->stock_id;
            $this->_userService->deleteFavorites($user_id, $stock_id);
            return ['message' => 'Favorite deleted successfully', 'code' => 200];
        } catch (\Exception $e) {
            throw $e;
        }
    }

}