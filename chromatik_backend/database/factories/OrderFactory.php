<?php

namespace Database\Factories;

use App\Http\Controllers\Api\UserController;
use App\Models\User;
use Illuminate\Database\Eloquent\Factories\Factory;

/**
 * @extends \Illuminate\Database\Eloquent\Factories\Factory<\App\Models\Order>
 */
class OrderFactory extends Factory
{
    /**
     * Define the model's default state.
     *
     * @return array<string, mixed>
     */
    public function definition(): array
    {

        $user_id = $this->faker->numberBetween(1, 10); // Générer un seul user_id pour toutes les commandes

$numberOfCommands = $this->faker->numberBetween(1, 5); 

$commands = [
    'user_id' => $user_id,
    'command_details' => []
];

for ($i = 0; $i < $numberOfCommands; $i++) {
    $commands['command_details'][] = [
        'stock_id' => $this->faker->numberBetween(1, 12),
        'quantity' => $this->faker->numberBetween(1, 100)
    ];
}

        return [
            'date' => $this->faker->date(),
            'status' => $this->faker->word(),
            'command' => json_encode($commands),
            'total_amount' => $this->faker->randomFloat(2, 0, 1000)
        ];
    }
}
