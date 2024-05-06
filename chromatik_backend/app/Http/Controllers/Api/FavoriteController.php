<?php

namespace App\Http\Controllers\Api;
use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use App\Http\Resources\FavoriteResource;
use App\Http\Services\FavoriteService;
class FavoriteController extends Controller
{
    public function __construct(private FavoriteService $_favoriteService){}

    public function indexFav()
    {
        try {
            $favorite = $this->_favoriteService->getFavorites();
            return FavoriteResource::collection($favorite);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function showFav(int $id)
    {
        try {
            $favorite = $this->_favoriteService->getFavoritesByUserId($id);
            return FavoriteResource::collection($favorite);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function storeFav(Request $request)
    {
        try {
            $favorite = $this->_favoriteService->storeFavorites($request);
            return new FavoriteResource($favorite);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function destroyFav(int $user_id, Request $request)
    {
        try {
            return $this->_favoriteService->deleteFavorites($user_id, $request->stock_id);
        } catch (\Exception $e) {
            throw $e;
        }
    }
}