<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    public function up(): void
    {
        Schema::create('carts', function (Blueprint $table) {
            $table->id('cart_id');
            $table->unsignedBigInteger('user_id');
            $table->unsignedBigInteger('stock_id');
            $table->integer('quantity');
            $table->timestamps();
            $table->foreign('user_id')->references('id')->on('users')->onDelete('restrict')->onUpdate('restrict');
            $table->foreign('stock_id')->references('stock_id')->on('stocks')->onDelete('restrict')->onUpdate('restrict');
            });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('carts');
    }
};
