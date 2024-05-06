<?php

namespace App\Http\Services;
use Illuminate\Support\Facades\Validator;
use Illuminate\Http\Exceptions\HttpResponseException;
use Illuminate\Http\Request;
use App\Models\Favorite;

class FavoriteService {

    /**
     * Get all favorites for all users
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
    public function getFavoriteById($id) {
        return Favorite::find($id);
    }

    /**
     * Get all favorites for a specific user
     * @param $id the id of the user
     * @return \Illuminate\Database\Eloquent\Collection
     */
    public function getFavoritesByUserId($id) {
        return Favorite::where('user_id', $id)->get();
    }


    /**
     * Store a new favorite
     * @param $request the request object containing the user_id and stock_id
     * @return Favorite
     */
    public function storeFavorites(Request $request) {
        $validator = Validator::make($request->all(), [
            'user_id' => 'required',
            'stock_id' => 'required'
        ]);

        if($validator->fails()) {
            throw new HttpResponseException(response()->json($validator->errors(), 422));
        }
        $favorite = new Favorite();
        $favorite->user_id = $request->input('user_id');
        $favorite->stock_id = $request->input('stock_id');
        $favorite->save();
        return $favorite;
    }

    /**
     * There is no update method for favorites, either a stock is a favorite or it is not
     * If a user wants to update a favorite, they can delete it and create a new one
     */

    /**
     * Delete a favorite
     * @param $userId the id of the user who wants to delete the favorite
     * @param $stockId the id of the stock to delete from favorites
     * @return bool | null
     */
    public function deleteFavorites($userId, $stockId) {
        $favorite = Favorite::where('user_id', $userId)->where('stock_id', $stockId)->first();
        
        if($favorite) {
            return $favorite->delete();
        }     
        return null;
    }
}