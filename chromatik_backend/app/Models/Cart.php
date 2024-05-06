<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Cart extends Model
{
    use HasFactory;

    protected $primaryKey = 'cart_id';
    protected $fillable = ['user_id','stock_id','quantity'];

    protected $hidden = ['created_at','updated_at'];

    public function user(){
        return $this->belongsTo(User::class);
    }
    public function stock(){
        return $this->belongsTo(Stock::class);
    }
}
