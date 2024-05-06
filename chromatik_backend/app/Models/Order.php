<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Order extends Model
{
    use HasFactory;

    protected $primaryKey = 'order_id';

    protected  $fillable = ['date','status','command','total_amount','user_id'];
    
    protected $hidden = ['created_at','updated_at'];

    public function user(){
        return $this->belongsTo(User::class, 'user_id');
    }
        


}
