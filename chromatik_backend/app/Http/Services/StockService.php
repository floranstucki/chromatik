<?php

namespace App\Http\Services;
use Illuminate\Support\Facades\Validator;
use Illuminate\Http\Exceptions\HttpResponseException;
use Illuminate\Http\Request;
use App\Models\Stock;
class StockService{
    
    /**
     * Get all stocks
     * @return \Illuminate\Database\Eloquent\Collection
     */
    public function getStocks() {
        return Stock::all();
    }

    /**
     * Get a stock by its id
     * @param $id the id of the stock
     * @return Stock
     */
    public function getStockById(int $id) {
        return Stock::find($id);
    }

    /**
     * Store a new stock
     * @param $request the request object containing the supply, brand, type, price, quantity and supplier_id
     * @return Stock
     */
    public function storeStock(Request $request){
        try{
            $validator = Validator::make($request->all(), [
                'supply' => 'required|string|max:255',
                'brand' => 'required|string|max:255',
                'type' => 'required|string|max:255',
                'price' => 'required|numeric|max',
                'quantity' => 'required|integer',
                'supplier_id' => 'required|integer'
            ]);
            if ($validator->fails()) {
                throw new HttpResponseException(
                    response()->json($validator->errors(), 422)
                );
            }
            $stock = new Stock();
            $stock->supply = $request->input('supply');
            $stock->brand = $request->input('brand');
            $stock->type = $request->input('type');
            $stock->price = $request->input('price');
            $stock->quantity = $request->input('quantity');
            $stock->supplier_id = $request->input('supplier_id');
            $stock->save();
            return $stock;
        }catch(\Exception $e){
            throw $e;
        }
    }

    /**
     * Update a stock
     * @param $request the request object containing the supply, brand, type, price, quantity and supplier_id
     * @param $id the id of the stock
     * @return Stock | null
     */
    public function updateStock(Request $request, int $id){
        try{
            $validator = Validator::make($request->all(), [
                'supply' => 'string|max:255',
                'brand' => 'string|max:255',
                'type' => 'string|max:255',
                'price' => 'numeric',
                'quantity' => 'integer',
                'supplier_id' => 'integer'
            ]);
            if ($validator->fails()) {
                throw new HttpResponseException(
                    response()->json($validator->errors(), 422)
                );
            }

            $stock = $this->getStockById($id);

            if($stock == null){
                return null;
            }
            $stock->fill($request->only([
                'supply', 'brand', 'type', 'price',
                'quantity', 'supplier_id'
            ]));
    
            // Enregistrer les modifications
            $stock->save();
    
            return $stock;
        }catch(\Exception $e){
            throw $e;
        
        }
    }

    /**
     * Delete a stock
     * @param $id the id of the stock
     * @return bool
     */
    public function deleteStock(int $id){
        $order = $this->getStockById($id);
        if($order == null){
            return false;
        }
        return $order->delete();
    }
}