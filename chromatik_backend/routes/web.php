<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\Api\PdfController;
use App\Http\Controllers\Api\CartController;
use App\Http\Controllers\Api\UserController;
use App\Http\Controllers\Api\SupplierController;
use App\Http\Controllers\Api\OrderController;
use App\Http\Controllers\Api\StockController;
use App\Http\Controllers\Api\RegisterController;

Route::get('/', function () {
    return view('welcome');
});

Route::controller(RegisterController::class)->group(function(){
    Route::post('register', 'register');
    Route::post('login', 'login');
});

/**
 * To acess the routes below, the user must be authenticated
 */
Route::middleware('auth:sanctum')->group(function () {  

    Route::apiResource('/orders', OrderController::class); 
    Route::get('/orders/{id}/generate', [PdfController::class,'generate']);    
    
    
    Route::apiResource('/carts', CartController::class);



    Route::get('/stock', [StockController::class, "index"]);
    Route::get('/stock/{id}', [StockController::class, "show"]);

    /**
     * The user must have the permission to create, update or delete a stock
     */
    Route::group(['middleware' => ['can:create stock']], function () {
        Route::post('/stock', [StockController::class, "store"]);
    });
    Route::group(['middleware' => ['can:update stock']], function () {
        Route::put('/stock/{id}', [StockController::class, "update"]);
    });
    Route::group(['middleware' => ['can:delete stock']], function () {
        Route::delete('/stock/{id}', [StockController::class, "destroy"]);
    });


    /**
     * Either for the supplier, the user must have the permission to create, update or delete a supplier
     */
    Route::get('/suppliers', [SupplierController::class,"index"]);
    Route::get('/suppliers/{id}', [SupplierController::class,"show"]);
    Route::group(['middleware' => ['can:create suppliers']], function () {
        Route::post('/suppliers', [SupplierController::class, "store"]);
    });
    Route::group(['middleware' => ['can:update suppliers']], function () {
        Route::put('/suppliers/{id}', [SupplierController::class, "update"]); 
    });
    Route::group(['middleware' => ['can:delete suppliers']], function () {
        Route::delete('/suppliers/{id}', [SupplierController::class, "destroy"]);
    });



    Route::get('/users', [UserController::class, 'index']);
    Route::get('/users/{id}', [UserController::class, 'show']);
    Route::put('/users/{id}', [UserController::class, 'update']);
    /**
     * The user must have the permission to delete a user
     */
    Route::group(['middleware' => ['can:delete user']], function () {
        Route::delete('/users/{id}', [UserController::class, 'destroy']);
    });
    Route::get('/users/{id}/favorites',[UserController::class, 'showFav']); 
    Route::get('/users/{id}/carts',[CartController::class,'findByUserId']); 
    Route::post('/users/{id}/favorites',[UserController::class, 'storeFav']); 
    Route::delete('/users/{id}/favorites',[UserController::class, 'destroyFav']); 
});