<?php

namespace App\Http\Resources;

use Illuminate\Http\Request;
use Illuminate\Http\Resources\Json\JsonResource;

class StockResource extends JsonResource
{
    /**
     * Transform the resource into an array.
     *
     * @return array<string, mixed>
     */
    public function toArray(Request $request): array
    {
        if ($this->resource){
        return [
            'stock_id' => $this->stock_id,
            'supply' => $this->supply,
            'brand' => $this->brand,
            'type' => $this->type,
            'price' => $this->price,
            'quantity' => $this->quantity,
            'supplier_id' => $this->supplier_id
        ];
    }
    return [];
    }
}
