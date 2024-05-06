<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Stock extends Model
{
    use HasFactory;
    protected $primaryKey = 'stock_id';

    protected $fillable = ['supply','brand','type','price','quantity','supplier_id'];

    protected $hidden = ['created_at','updated_at'];

    public function cart(){
        return $this->hasMany(Cart::class);
    }
    public function supplier(){
        return $this->belongsTo(Supplier::class);
    }
}
