<?php 

namespace App\Http\Controllers\Api;
use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use App\Http\Resources\OrderResource;
use App\Http\Services\OrderService;

class OrderController extends Controller{
    public function __construct(private OrderService $_orderService){}

    public function index()
    {
        try {
            $order =  $this->_orderService->getOrders();
            if($order->isEmpty()){
                return response()->json(['message' => 'No orders found'], 404);
            }
            return OrderResource::collection($order);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function show(int $id)
    {
        try {
            $order= $this->_orderService->getOrderById($id);
            return OrderResource::collection($order);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function store(Request $request)
    {
        try {
            $order = $this->_orderService->storeOrder($request);
            return new OrderResource($order);
            
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function update(Request $request, int $id)
    {
        try {
            $order = $this->_orderService->updateOrder($request, $id);
            return new OrderResource($order);
        } catch (\Exception $e) {
            throw $e;
        }
    }
    public function destroy(int $id)
    {
        try {
            return response()->json(['message' => 'Impossible to delete Orders'], 404);
        } catch (\Exception $e) {
            throw $e;
        }
    }
}