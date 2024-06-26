<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Favorite extends Model
{
    use HasFactory;

    protected $fillable = ['user_id', 'stock_id','created_at'];
    protected $hidden = ['updated_at'];

    public function user(){
        return $this->belongsTo(User::class);
    }

    public function stock(){
        return $this->belongsTo(Stock::class);
    }

}