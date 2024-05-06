<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Supplier extends Model
{
    use HasFactory;

    protected $primaryKey = 'supplier_id';

    protected $fillable = ['name','address','phone_number','npa','city','email'];
    protected $hidden = ['created_at','updated_at'];

    public function stock(){
        return $this->hasMany(Stock::class);
    }
}
