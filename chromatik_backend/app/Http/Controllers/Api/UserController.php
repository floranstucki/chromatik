<?php

namespace App\Http\Controllers\Api;
use App\Http\Controllers\Controller;
use App\Http\Resources\FavoriteResource;
use App\Http\Resources\OrderResource;
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
            return UserResource::collection($users)->collection;
        } catch (\Exception $e) {
            throw $e;
        }
    }
    public function show(int $id){
        try {
            $user= $this->_userService->getUserById($id);
            return UserResource::make($user)->resource;
        } catch (\Exception $e) {
            throw $e;
        }
    }
    public function update(Request $request, int $id){
        try {
            $this->_userService->updateUser($request, $id);
            $user = $this->_userService->getUserById($id);
            return new UserResource($user);
        } catch (\Exception $e) {
            throw $e;
        }
    }
    public function destroy(int $id){
        try {
            return $this->_userService->deleteUser($id);
        } catch (\Exception $e) {
            throw $e;
        }
    }
    public function showFav(int $id)
    {
        try {
            $favorite = $this->_userService->getFavoritesByUserId($id);
            return FavoriteResource::make($favorite)->resource;
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function storeFav(Request $request)
    {
        try {
            $favorite = $this->_userService->storeFavorites($request);
            return new FavoriteResource($favorite);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function destroyFav(int $user_id, Request $request)
    {
        try {
            return $this->_userService->deleteFavorites($user_id, $request->stock_id);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function showOrderByUserId(int $id)
    {
        try {
            $order= $this->_userService->getOrderByUserId($id);
            return OrderResource::collection($order)->collection;
        } catch (\Exception $e) {
            throw $e;
        }
    }

}