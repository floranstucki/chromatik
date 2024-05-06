<?php 

namespace App\Http\Services;
use Illuminate\Support\Facades\Validator;
use Illuminate\Http\Exceptions\HttpResponseException;
use Illuminate\Http\Request;
use App\Models\User;
use App\Models\Favorite;
class UserService{

    /**
     * Get all users
     * @return \Illuminate\Database\Eloquent\Collection
     */
    public function getUsers() {
        return User::all();
    }

    /**
     * Get a user by its id
     * @param $id the id of the user
     * @return User
     */
    public function getUserById(int $id) {
        return User::find($id);
    }

    /**
     * Store a new user
     * @param $request the request object containing the name, first_name, phone_number, username, email, isAdmin, password and remember_token
     * @return User
     */
    public function updateUser(Request $request, int $id){
        try{
            $validator = Validator::make($request->all(), [
                'name' => 'max:255',
                'first_name' => 'string|max:255',
                'phone_number' => 'string|max:255',
                'username' => 'string|max:255',
                'email' => 'email|max:255',
                'isAdmin' => 'string|max:255',
                'password' => 'string|max:255'
            ]);
            
            if ($validator->fails()) {
                throw new HttpResponseException(
                    response()->json($validator->errors(), 422)
                );
            }
    
            // Récupérer l'utilisateur existant
            $user = $this->getUserById($id);
    
            $user->fill($request->only([
                'name', 'first_name', 'phone_number', 'username',
                'email', 'isAdmin', 'password'
            ]));
    
            // Enregistrer les modifications
            $user->save();
    
            return $user;
        } catch(\Exception $e){
            throw $e;
        }
    }
    
    /**
     * delete a user
     * @param $id the id of the user
     * @return User | null
     */
    public function deleteUser(int $id){
        try{
            $user = $this->getUserById($id);
            if($user == null){
                return null;
            }
            return $user->delete();
        }
        catch(\Exception $e){
            throw $e;
        }
    }


    /**
     * Get all favorites
     * @return \Illuminate\Database\Eloquent\Collection
     */
    public function getFavorites() {
        return Favorite::all();
    }

    /**
     * Get a favorite by its id
     * @param $id the id of the favorite
     * @return Favorite
     */
    public function getFavoriteById(int $id) {
        return Favorite::find($id);
    }

    /**
     * Get all favorites for a specific user
     * @param $id the id of the user
     * @return \Illuminate\Database\Eloquent\Collection
     */
    public function getFavoritesByUserId(int $id) {
        return Favorite::where('user_id', $id)->get();
    }

    /**
     * Store a new favorite
     * @param $request the request object containing the user_id and stock_id
     * @return Favorite
     */
    public function storeFavorites(int $user_id,Request $request) {
        $validator = Validator::make($request->all(), [
            'stock_id' => 'required'
        ]);

        if($validator->fails()) {
            throw new HttpResponseException(response()->json($validator->errors(), 422));
        }
        $favorite = new Favorite();
        $favorite->user_id = $user_id;
        $favorite->stock_id = $request->input('stock_id');
        $favorite->save();
        return $favorite;
    }

    /**
     * Delete a favorite
     * @param $userId the id of the user who wants to delete the favorite
     * @param $stockId the id of the stock to delete from favorites
     * @return Favorite | null
     */
    public function deleteFavorites(int $userId, int $stockId) {
        
        $favorite = Favorite::where('user_id', $userId)->where('stock_id', $stockId)->first();
        
        if($favorite) {
            return $favorite->delete();
        } 
        return null;
    }
}