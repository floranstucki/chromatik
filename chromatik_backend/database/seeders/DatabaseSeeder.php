<?php

namespace Database\Seeders;

use App\Models\Order;
use App\Models\Supplier;
use App\Models\User;
use App\Models\Cart;
use App\Models\Stock;
use Illuminate\Database\Seeder;
use SebastianBergmann\CodeUnit\FunctionUnit;
use Spatie\Permission\Models\Permission;
use Spatie\Permission\Models\Role;

class DatabaseSeeder extends Seeder
{
    /**
     * Seed the application's database.
     */
    public function run(): void
    {
        $user = User::factory()->count(10)->create();
        $supplier = Supplier::factory()->count(5)->create();

        $stock = Stock::factory()->count(12)->make()->each(function ($stock) use ($supplier) {
            $stock->supplier_id = $supplier->random()->supplier_id;
            $stock->save();
        });

        Cart::factory()->count(2)->make()->each(function ($cart) use ($user, $stock) {
            $cart->user_id = $user->random()->id;
            $cart->stock_id = $stock->random()->stock_id;
            $cart->save();
        });

        Order::factory()->count(1)->make()->each(function ($order) use ($user) {

            $order->user_id = $user->random()->id;
            $order->save();
        });


        $roleManage = Role::create(['name' => 'manage']);

        /**
         * We need to create all permissions for the manage role for the api routes
         */
        $permCreateStock = Permission::create(['name' => 'create stock']);
        $permCreateSupplier = Permission::create(['name' => 'create suppliers']);

        $permUpdateStock = Permission::create(['name' => 'update stock']);
        $permUpdateSupplier = Permission::create(['name' => 'update suppliers']);
        $permUpdateOrder = Permission::create(['name' => 'update order']);

        $permDeleteStock = Permission::create(['name' => 'delete stock']);
        $permDeleteSupplier = Permission::create(['name' => 'delete suppliers']);
        $permDeleteOrder = Permission::create(['name' => 'delete order']);
        $permDeleteUser = Permission::create(['name' => 'delete user']);

        $roleManage->syncPermissions([$permDeleteStock, $permDeleteSupplier, $permDeleteOrder, $permDeleteUser, $permUpdateStock, $permUpdateSupplier, $permUpdateOrder, $permCreateStock, $permCreateSupplier]);


        // Je crée un utilisateur avec le rôle admin
        $userAdmin = User::factory()->create([
            'name' => 'Admin',
            'first_name' => 'Admin',
            'phone_number' => '+41791234567',
            'email' => 'admin.example@gmail.com',
            'password' => bcrypt('admin')
        ]);
        $userAdmin->syncRoles($roleManage);

        User::factory()->create([
            'name' => 'test',
            'first_name' => 'test',
            'phone_number' => '+41234567890',
            'email' => 'test@example.com',
            'password' => bcrypt('test')
        ]);
    }
}
