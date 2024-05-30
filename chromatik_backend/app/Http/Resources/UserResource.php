<?php

namespace App\Http\Resources;

use Illuminate\Http\Request;
use Illuminate\Http\Resources\Json\JsonResource;

class UserResource extends JsonResource
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
                'id' => $this->id,
                'name' => $this->name,
                'first_name' => $this->first_name,
                'phone_number' => $this->phone_number,
                'email' => $this->email,
                'password'  => $this->password,
                'role' => $this->role,
            ];
        }
        return [];
    }
}
