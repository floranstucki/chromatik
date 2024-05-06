<?php

namespace App\Http\Controllers\Api;
use App\Http\Controllers\Controller;
use App\Models\Order;
use Illuminate\Http\Request;
use Barryvdh\DomPDF\Facade\Pdf;


class PdfController extends Controller
{
    public function generate(Request $request){
        $order = Order::find($request->id);
        $commands = json_decode($order->command, true);
        $data=[
            'title' => 'Order number ' . $order->order_id,
            'date' => $order->date,
            'command' => $commands, 
            'total_amount' => $order->total_amount,
        ];
        $pdf = Pdf::loadView("order", $data);
        return $pdf->download('order_'.$order->order_id.'.pdf');
    }
    
}
