<?php

namespace App\Http\Services;

use App\Models\User;
use Illuminate\Support\Facades\Validator;
use Illuminate\Http\Exceptions\HttpResponseException;
use Illuminate\Http\Request;
use App\Models\Cart;

class CartService
{
    /**
     * Display a listing of carts
     * @return \Illuminate\Database\Eloquent\Collection
     */
    public function getCarts()
    {
        return Cart::all();
    }

    /**
     * Display a cart specified by id
     * @param int $id
     * @return \Illuminate\Database\Eloquent\Collection
     */
    public function getCartById(int $id)
    {
        return Cart::find($id);
    }
    
    
    /**
     * Display a cart specified by user id
     * @param int $id
     * @return \Illuminate\Database\Eloquent\Collection
     */
    public function getCartByUserId(int $id)
    {
        return Cart::where('user_id', $id)->get();
    }

    /**
     * Store a newly created cart in storage.
     *
     * This function validates the data received, creates a new entry in the "carts" table
     * table with the information provided, then returns a JSON response with a success message.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\JsonResponse
     * @throws \Exception Thorwn if an error occurs while storing the cart
     */
    public function storeCart(Request $request)
    {
        try {
            $validator = Validator::make($request->all(), [
                'user_id' => 'required|integer|digits_between:1,20',
                'stock_id' => 'required|integer|digits_between:1,20',
                'quantity' => 'required|integer|digits_between:1,20'
            ]);

            if ($validator->fails()) {
                throw new HttpResponseException(
                    response()->json($validator->errors(), 422)
                );
            }

            $cart = new Cart();
            $cart->user_id = $request->input('user_id');
            $cart->stock_id = $request->input('stock_id');
            $cart->quantity = $request->input('quantity');
            $cart->save();

            return response()->json(['message' => 'Stock added to cart successfully','cart' => $cart], 200);

        } catch (\Exception $e) {
            throw ($e);
        }
    }


    /**
     * Update the specified cart in storage.
     *
     * This function validates the data received, updates the entry in the "carts" table
     * table with the information provided, then returns the updated cart.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Database\Eloquent\Collection
     * @throws \Exception Thrown if an error occurs while updating the cart
     */
    public function updateCart(Request $request, int $id)
    {
        try {
            $validator = Validator::make($request->all(), [
                'quantity' => 'required|integer|digits_between:1,20'
            ]);

            if ($validator->fails()) {
                throw new HttpResponseException(
                    response()->json($validator->errors(), 422)
                );
            }

            $cart = $this->getCartById($id);

            // Mettre à jour uniquement les champs remplis dans la requête
            $cart->fill($request->only([
                'quantity'
            ]));
            $cart->save();

            return $cart;

        } catch (\Exception $e) {
            throw $e;
        }
    }

    /**
     * Remove the specified cart from storage.
     *
     * This function deletes the entry in the "carts" table
     * table with the information provided, then returns the deleted cart.
     *
     * @param  int  $id
     * @return bool | null
     * @throws \Exception Thrown if an error occurs while deleting the cart
     */
    public function deleteCart(int $id)
    {
        try {
            $cart = $this->getCartById($id);
            if ($cart == null) {
                return null;
            }
            return $cart->delete();
            

        } catch (\Exception $e) {
            throw $e;
        }
    }
}