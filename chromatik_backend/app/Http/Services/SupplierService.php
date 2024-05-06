<?php

namespace App\Http\Services;
use Illuminate\Support\Facades\Validator;
use Illuminate\Http\Exceptions\HttpResponseException;
use Illuminate\Http\Request;
use App\Models\Supplier;

class SupplierService{

    /**
     * Get all suppliers
     * @return \Illuminate\Database\Eloquent\Collection
     */
    public function getSuppliers() {
        return Supplier::all();
    }

    /**
     * Get a supplier by its id
     * @param $id the id of the supplier
     * @return Supplier
     */
    public function getSupplierById(int $id) {
        return Supplier::find($id);
    }

    /**
     * Store a new supplier
     * @param $request the request object containing the name, address, phone_number, npa, city and email
     * @return Supplier
     */
    public function storeSupplier(Request $request){
        try {
            $validator = Validator::make($request->all(), [
                'name' => 'required|max:255',
                'address' => 'required|string|max:255',
                'phone_number' => 'required|string|max:25',
                'npa' => 'required|integer|max:99999',
                'city' => 'required|string|max:255',
                'email' => 'required|email|max:255',
            ]);

            if ($validator->fails()) {
                throw new HttpResponseException(
                    response()->json($validator->errors(), 422)
                );
            }

            $supplier = new Supplier();
            $supplier->name = $request->input('name');
            $supplier->address = $request->input('address');
            $supplier->phone_number = $request->input('phone_number');
            $supplier->npa = $request->input('npa');
            $supplier->city = $request->input('city');
            $supplier->email = $request->input('email');
            $supplier->save();

            return $supplier;

        } catch (\Exception $e) {
            throw ($e);
        }
    }

    /**
     * Update a supplier
     * @param $request the request object containing the name, address, phone_number, npa, city and email
     * @param $id the id of the supplier
     * @return Supplier | null
     */
    public function updateSupplier(Request $request, int $id){
        try {
            $validator = Validator::make($request->all(), [
                'name' => 'max:255',
                'address' => 'string|max:255',
                'phone_number' => 'string|max:25',
                'npa' => 'integer',
                'city' => 'string|max:255',
                'email' => 'email|max:255',
            ]);

            if ($validator->fails()) {
                throw new HttpResponseException(
                    response()->json($validator->errors(), 422)
                );
            }

            $supplier = $this->getSupplierById($id);
    
            if (!$supplier) {
                return null;
            }
            // Mettre à jour uniquement les champs remplis dans la requête
            $supplier->fill($request->only([
                'name', 'address', 'phone_number', 'npa',
                'city', 'email'
            ]));
            $supplier->save();
            return $supplier;

        } catch (\Exception $e) {
            throw ($e);
        }
    }

    /**
     * Delete a supplier
     * @param $id the id of the supplier to delete
     * @return bool
     */
    public function deleteSupplier(int $id){
        $supplier = $this->getSupplierById($id);
        return $supplier->delete();
    }
}