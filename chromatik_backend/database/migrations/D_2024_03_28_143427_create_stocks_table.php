<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('stocks', function (Blueprint $table) {
            $table->id('stock_id');
            $table->string('supply');
            $table->string('brand');
            $table->string('type');
            $table->integer('price');
            $table->integer('quantity');
            $table->unsignedBigInteger('supplier_id');
            $table->foreign('supplier_id')->references('supplier_id')->on('suppliers')->onDelete('restrict')->onUpdate('restrict');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('stocks');
    }
};
