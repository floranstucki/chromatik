<?php

namespace Database\Factories;

use Illuminate\Database\Eloquent\Factories\Factory;

/**
 * @extends \Illuminate\Database\Eloquent\Factories\Factory<\App\Models\Stock>
 */
class StockFactory extends Factory
{
    /**
     * Define the model's default state.
     *
     * @return array<string, mixed>
     */
    public function definition(): array
    {
        return [
            'supply' => $this->faker->name(),
            'brand' => $this->faker->company(),
            'type' => $this->faker->word(),
            'price' => $this->faker->randomFloat(2, 0, 1000),
            'quantity' => $this->faker->numberBetween(0, 100)
        ];
    }
}
