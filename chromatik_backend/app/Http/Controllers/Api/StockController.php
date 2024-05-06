<?php

namespace App\Http\Controllers\Api;
use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use App\Http\Resources\StockResource;
use App\Http\Services\StockService;
class StockController extends Controller{
    public function __construct(private StockService $_stockService){}

    public function index()
    {
        try {
            $stock =  $this->_stockService->getStocks();
            if($stock->isEmpty()){
                return response()->json(['message' => 'No stock found'], 404);
            }
            return StockResource::collection($stock);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function show(int $id)
    {
        try {
            $stock = $this->_stockService->getStockById($id);
            return StockResource::collection($stock);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function store(Request $request)
    {
        try {
           $stock = $this->_stockService->storeStock($request);
            return new StockResource($stock);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function update(Request $request, int $id)
    {
        try {
            $stock = $this->_stockService->updateStock($request,$id);
            if ($stock == null) {
                return response()->json(['message' => 'Stock not found'], 404);
            }
            return response()->json(['message' => 'Stock updated successfully', 'stock' => $stock]);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function destroy(int $id)
    {
        try {
            $this->_stockService->deleteStock($id);
            return response()->json(['message' => 'Stock deleted successfully']);
        } catch (\Exception $e) {
            throw $e;
        }
    }
}