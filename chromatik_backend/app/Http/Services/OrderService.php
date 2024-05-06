<?php

namespace App\Http\Services;
use Illuminate\Support\Facades\Storage;
use Illuminate\Support\Facades\Validator;
use Illuminate\Http\Exceptions\HttpResponseException;
use Illuminate\Http\Request;
use App\Models\Order;
use PDF;

class OrderService{

    /**
     * Get all orders from the datavbase
     * @return \Illuminate\Database\Eloquent\Collection 
     */
    public function getOrders() {
        return Order::all();
    }

    /**
     * Get an order by its id
     * @param $id the id of the order
     * @return Order
     */
    public function getOrderById(int $id) {
        return Order::find($id);
    }
    
    /**
     * Store a new order
     * @param $request the request object containing the date, status, command, total_amount and user_id
     * @return Order
     */
    public function storeOrder(Request $request) {
        try {
            $validator = Validator::make($request->all(), [
                'date' => 'required|date',
                'status' => 'required|string|max:255',
                'command' => 'required|json',
                'total_amount' => 'required|numeric',
                'user_id' => 'required|integer|digits_between:1,20'
            ]);

            if ($validator->fails()) {
                throw new HttpResponseException(
                    response()->json($validator->errors(), 422)
                );
            }

            $order = new Order();
            $order->date = $request->input('date');
            $order->status = $request->input('status');
            $order->command = $request->input('command');
            $order->total_amount = $request->input('total_amount');
            $order->user_id = $request->input('user_id');
            $order->save();
            return $order;
        }catch(\Exception $e){
                throw $e;
            }
    }

    /**
     * Update an order
     * @param $request the request object containing the status
     * @param $id the id of the order
     * @return Order
     */
    public function updateOrder(Request $request, int $id) {
        try {
            $validator = Validator::make($request->all(), [
                'status' => 'required|string|max:255'
            ]);

            if ($validator->fails()) {
                throw new HttpResponseException(
                    response()->json($validator->errors(), 422)
                );
            }

            $order = $this->getOrderById($id);
            $order->status = $request->input('status');
            $order->save();
            return $order;
        }catch(\Exception $e){
                throw $e;
            }
    }
    /**
     * Delete an order
     * @param $id the id of the order
     * @return bool | null
     */
    public function deleteOrder(int $id){
        $order = $this->getOrderById($id);
        if($order == null){
            return null;
        }
        return $order->delete();
        
    }
}