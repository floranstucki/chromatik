<?php

namespace App\Http\Resources;

use Illuminate\Http\Request;
use Illuminate\Http\Resources\Json\JsonResource;

class FavoriteResource extends JsonResource
{
    /**
     * Transform the resource into an array.
     *
     * @return array<string, mixed>
     */
    public function toArray(Request $request): array
    {
     if($this->resource){
        return [
            'user_id' => $this->user_id,
            'stock_id' => $this->stock_id,
            'date' => $this->created_at
        ];
        }
        return [];
    }
}
