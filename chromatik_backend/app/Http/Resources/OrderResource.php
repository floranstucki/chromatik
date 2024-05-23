<?php

namespace App\Http\Resources;

use Illuminate\Http\Request;
use Illuminate\Http\Resources\Json\JsonResource;

class OrderResource extends JsonResource
{
    /**
     * Transform the resource into an array.
     *
     * @return array<string, mixed>
     */
    public function toArray(Request $request): array
    {
        //return parent::toArray($request);
        if ($this->resource) {
            return [
                'order_id'=> $this->order_id,
                'date' => $this->date,
                'status' => $this->status,
                'command' => $this->command,
                'total_amount' => $this->total_amount,
                'user_id' => $this->user_id
            ];
        }
        return [];
    }
}
