<?php

namespace App\Http\Controllers\Api;
use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use App\Http\Resources\CartResource;
use App\Http\Services\CartService;
class CartController extends Controller{

    public function __construct(private CartService $_cartService){}

    /**
     * Display a listing of carts
     */
    public function index()
    {
        try {
            $cart =  $this->_cartService->getCarts();
            return CartResource::collection($cart);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    /**
     * Display a cart specified by id
     */
    public function show(int $id)
    {
        try {
            $cart = $this->_cartService->getCartById($id);
            return CartResource::make($cart)->resource;
        } catch (\Exception $e) {
            throw $e;
        }
    }

    /**
     * Display a cart specified by user id
     */
    public function findByUserId(int $id)
    {
        try {
            $cart = $this->_cartService->getCartByUserId($id);
            return CartResource::make($cart)->resource;
        } catch (\Exception $e) {
            throw $e;
        }
    }

    /**
     * Store a newly created cart in storage.
     */
    public function store(Request $request)
    {
        try {
            $cart =  $this->_cartService->storeCart($request);
            return CartResource::make($cart)->resource;
        } catch (\Exception $e) {
            throw $e;
        }
    }

    /**
     * Update the specified cart in storage.
     */
    public function update(Request $request, int $id)
    {
        try {
            return $this->_cartService->updateCart($request,$id);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    /**
     * Remove the specified cart from storage.
     */
    public function destroy(int $id, int $stockid)
    {
        try {
            $this->_cartService->deleteCart($id,$stockid);
            return response()->json(['message' => 'Cart deleted successfully']);
        } catch (\Exception $e) {
            throw $e;
        }
    }
}